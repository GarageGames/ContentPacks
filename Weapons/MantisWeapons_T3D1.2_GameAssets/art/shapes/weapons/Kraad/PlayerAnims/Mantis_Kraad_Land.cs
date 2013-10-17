singleton TSShapeConstructor(Mantis_Kraad_LandDAE)
{
   baseShape = "./Mantis_Kraad_Land.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Land", "910", "925", true, true);
}
