singleton TSShapeConstructor(Soldier_Kralmok_Death1DAE)
{
   baseShape = "./Soldier_Kralmok_Death1.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1090", "1130", true, true);
}
