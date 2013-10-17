singleton TSShapeConstructor(Soldier_Kraad_Death1DAE)
{
   baseShape = "./Soldier_Kraad_Death1.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1140", "1180", true, true);
}
