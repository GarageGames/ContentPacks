singleton TSShapeConstructor(Mantis_Kralmok_LookDAE)
{
   baseShape = "./Mantis_Kralmok_Look.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "1000", "1010", true, true);
}
