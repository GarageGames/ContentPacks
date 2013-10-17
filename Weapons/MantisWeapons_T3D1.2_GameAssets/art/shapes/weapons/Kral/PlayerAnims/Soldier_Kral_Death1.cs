singleton TSShapeConstructor(Soldier_Kral_Death1DAE)
{
   baseShape = "./Soldier_Kral_Death1.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1130", "1170", true, true);
}
