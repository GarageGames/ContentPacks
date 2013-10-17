singleton TSShapeConstructor(Mantis_Kraad_LookDAE)
{
   baseShape = "./Mantis_Kraad_Look.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "1000", "1010", true, true);
}
