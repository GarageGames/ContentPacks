singleton TSShapeConstructor(Soldier_Kraad_LandDAE)
{
   baseShape = "./Soldier_Kraad_Land.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Land", "1100", "1110", true, true);
}
