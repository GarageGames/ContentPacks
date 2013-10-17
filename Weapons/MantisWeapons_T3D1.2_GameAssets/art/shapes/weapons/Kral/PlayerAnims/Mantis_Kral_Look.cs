singleton TSShapeConstructor(Mantis_Kral_LookDAE)
{
   baseShape = "./Mantis_Kral_Look.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "1000", "1010", true, true);
}
