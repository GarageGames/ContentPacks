singleton TSShapeConstructor(Mantis_Kral_LandDAE)
{
   baseShape = "./Mantis_Kral_Land.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Land", "910", "925", true, true);
}
