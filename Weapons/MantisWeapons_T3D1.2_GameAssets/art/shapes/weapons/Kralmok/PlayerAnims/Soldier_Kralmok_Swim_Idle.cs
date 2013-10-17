singleton TSShapeConstructor(Soldier_Kralmok_Swim_IdleDAE)
{
   baseShape = "./Soldier_Kralmok_Swim_Idle.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Swim_IdleDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Idle", "1270", "1329", true, true);
}
