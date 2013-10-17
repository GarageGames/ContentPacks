singleton TSShapeConstructor(Soldier_Kral_RunDAE)
{
   baseShape = "./Soldier_Kral_Run.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "140", "159", true, true);
}
