using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using RimWorld;
using Verse;

namespace Elemental_Boomalopes {
    public class Alope {
        public static float DeathRadius(int lifeStage) {
            float radius;

            if (lifeStage == 0) {
                radius = 1.9f;
            } else if (lifeStage == 1) {
                radius = 2.9f;
            } else {
                radius = 4.9f;
            }

            return radius;
        }
    }
    public class Erat {
        public const float DeathRadius = 1.9f;
    }

    public class DeathActionWorker_BigExplosion_EMP : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            float radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.EMP, corpse.InnerPawn, -1, -1, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
        }
    }

    public class DeathActionWorker_BigExplosion_Stun : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            float radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Stun, corpse.InnerPawn, -1, -1, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
        }
    }

    public class DeathActionWorker_BigExplosion_FireFoam : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            float radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
            ThingDef filthFireFoam = ThingDefOf.Filth_FireFoam;
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Extinguish, corpse.InnerPawn, -1, -1, null, null, null, null, filthFireFoam, 1f, 2, true, null, 0f, 1, 0f, false);
        }
    }

    public class DeathActionWorker_BigExplosion_Smoke : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            float radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
            ThingDef gas_Smoke = ThingDefOf.Gas_Smoke;
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Smoke, corpse.InnerPawn, -1, -1, null, null, null, null, gas_Smoke, 1f, 1, false, null, 0f, 1, 0f, false);
        }
    }

    public class DeathActionWorker_SmallExplosion_EMP : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.EMP, corpse.InnerPawn, -1, -1, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
        }
    }

    public class DeathActionWorker_SmallExplosion_Stun : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.Stun, corpse.InnerPawn, -1, -1, null, null, null, null, null, 0f, 1, false, null, 0f, 1, 0f, false);
        }
    }

    public class DeathActionWorker_SmallExplosion_FireFoam : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            ThingDef filthFireFoam = ThingDefOf.Filth_FireFoam;
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.Extinguish, corpse.InnerPawn, -1, -1, null, null, null, null, filthFireFoam, 1f, 2, true, null, 0f, 1, 0f, false);
        }
    }

    public class DeathActionWorker_SmallExplosion_Smoke : DeathActionWorker {
        public override void PawnDied(Corpse corpse) {
            ThingDef gas_Smoke = ThingDefOf.Gas_Smoke;
            GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.Smoke, corpse.InnerPawn, -1, -1, null, null, null, null, gas_Smoke, 1f, 1, false, null, 0f, 1, 0f, false);
        }
    }
}