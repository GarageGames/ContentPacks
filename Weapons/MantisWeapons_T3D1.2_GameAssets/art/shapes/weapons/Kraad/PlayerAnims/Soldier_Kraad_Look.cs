singleton TSShapeConstructor(Soldier_Kraad_LookDAE)
{
   baseShape = "./Soldier_Kraad_Look.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "950", "960", true, true);
}
