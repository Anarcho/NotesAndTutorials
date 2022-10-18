namespace RimWorld
{
    public class Dialog_FormCaravan : Window
	{
        private bool CheckForErrors(List<Pawn> pawns)
        {
        	if (this.MustChooseRoute && this.destinationTile < 0)
        	{
        		Messages.Message("MessageMustChooseRouteFirst".Translate(), MessageTypeDefOf.RejectInput, false);
        		return false;
        	}
        	if (!this.reform && this.startingTile < 0)
        	{
        		Messages.Message("MessageNoValidExitTile".Translate(), MessageTypeDefOf.RejectInput, false);
        		return false;
        	}
        	if (!pawns.Any((Pawn x) => CaravanUtility.IsOwner(x, Faction.OfPlayer) && !x.Downed))
        	{
        		if (ModsConfig.IdeologyActive)
        		{
        			Messages.Message("CaravanMustHaveAtLeastOneNonSlaveColonist".Translate(), MessageTypeDefOf.RejectInput, false);
        		}
        		else
        		{
        			Messages.Message("CaravanMustHaveAtLeastOneColonist".Translate(), MessageTypeDefOf.RejectInput, false);
        		}
        		return false;
        	}
        	if (!this.reform && this.MassUsage > this.MassCapacity)
        	{
        		this.FlashMass();
        		Messages.Message("TooBigCaravanMassUsage".Translate(), MessageTypeDefOf.RejectInput, false);
        		return false;
        	}
        	for (int i = 0; i < this.transferables.Count; i++)
        	{
        		if (this.transferables[i].ThingDef.category == ThingCategory.Item)
        		{
        			int countToTransfer = this.transferables[i].CountToTransfer;
        			int num = 0;
        			if (countToTransfer > 0)
        			{
        				for (int j = 0; j < this.transferables[i].things.Count; j++)
        				{
        					Thing t = this.transferables[i].things[j];
        					if (!t.Spawned || pawns.Any((Pawn x) => x.IsColonist && x.CanReach(t, PathEndMode.Touch, Danger.Deadly, false, false, TraverseMode.ByPawn)))
        					{
        						num += t.stackCount;
        						if (num >= countToTransfer)
        						{
        							break;
        						}
        					}
        				}
        				if (num < countToTransfer)
        				{
        					if (countToTransfer == 1)
        					{
        						Messages.Message("CaravanItemIsUnreachableSingle".Translate(this.transferables[i].ThingDef.label), MessageTypeDefOf.RejectInput, false);
        					}
        					else
        					{
        						Messages.Message("CaravanItemIsUnreachableMulti".Translate(countToTransfer, this.transferables[i].ThingDef.label), MessageTypeDefOf.RejectInput, false);
        					}
        					return false;
        				}
        			}
        		}
        	}
        	return true;
        }
    }

}