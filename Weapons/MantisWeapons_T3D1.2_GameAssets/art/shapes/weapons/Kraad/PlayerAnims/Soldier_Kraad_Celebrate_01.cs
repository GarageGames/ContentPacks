singleton TSShapeConstructor(Soldier_Kraad_Celebrate_01DAE)
{
   baseShape = "./Soldier_Kraad_Celebrate_01.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Celebrate_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Celebrate_01", "2020", "2090", true, true);
}
