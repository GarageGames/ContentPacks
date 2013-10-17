singleton TSShapeConstructor(Mantis_Kralmok_LandDAE)
{
   baseShape = "./Mantis_Kralmok_Land.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Land", "910", "925", true, true);
}
