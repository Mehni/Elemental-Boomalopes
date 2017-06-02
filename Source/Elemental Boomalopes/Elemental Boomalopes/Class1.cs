using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using RimWorld;
using Verse;

namespace Elemental_Boomalopes
{
    public class DeathActionWorker_BigExplosion_EMP : DeathActionWorker
    {
        public override void PawnDied(Corpse corpse)
        {
            float radius;
            if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 0)
            {
                radius = 1.9f;
            }
            else if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 1)
            {
                radius = 2.9f;
            }
            else
            {
                radius = 4.9f;
            }
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.EMP, corpse.InnerPawn, null, null, null, null, 0f, 1, false, null, 0f, 1);
        }
    }

    public class DeathActionWorker_BigExplosion_Stun : DeathActionWorker
    {
        public override void PawnDied(Corpse corpse)
        {
            float radius;
            if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 0)
            {
                radius = 1.9f;
            }
            else if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 1)
            {
                radius = 2.9f;
            }
            else
            {
                radius = 4.9f;
            }
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Stun, corpse.InnerPawn, null, null, null, null, 0f, 1, false, null, 0f, 1);
        }
    }

    public class DeathActionWorker_BigExplosion_FireFoam : DeathActionWorker
    {
        public override void PawnDied(Corpse corpse)
        {
            float radius;
            if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 0)
            {
                radius = 3.8f;
            }
            else if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 1)
            {
                radius = 5.8f;
            }
            else
            {
                radius = 9.8f;
            }
            ThingDef filthFireFoam = ThingDefOf.FilthFireFoam;
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Extinguish, corpse.InnerPawn, null, null, null, filthFireFoam, 1f, 2, true, null, 0f, 1);
        }
    }

    public class DeathActionWorker_BigExplosion_Smoke : DeathActionWorker
    {
        public override void PawnDied(Corpse corpse)
        {
            float radius;
            if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 0)
            {
                radius = 3.8f;
            }
            else if (corpse.InnerPawn.ageTracker.CurLifeStageIndex == 1)
            {
                radius = 5.8f;
            }
            else
            {
                radius = 9.8f;
            }
            ThingDef gas_Smoke = ThingDefOf.Gas_Smoke;
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Smoke, corpse.InnerPawn, null, null, null, gas_Smoke, 1f, 1, false, null, 0f, 1);
        }
    }


}
