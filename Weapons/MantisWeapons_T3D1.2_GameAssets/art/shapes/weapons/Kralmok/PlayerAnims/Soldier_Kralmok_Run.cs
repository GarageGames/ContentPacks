singleton TSShapeConstructor(Soldier_Kralmok_RunDAE)
{
   baseShape = "./Soldier_Kralmok_Run.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "140", "159", true, true);
}
