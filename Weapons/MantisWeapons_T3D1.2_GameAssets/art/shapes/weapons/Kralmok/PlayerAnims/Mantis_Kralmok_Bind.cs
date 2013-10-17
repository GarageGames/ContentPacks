singleton TSShapeConstructor(Mantis_Kralmok_BindDAE)
{
   baseShape = "./Mantis_Kralmok_Bind.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_BindDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Bind", "0", "1", true, true);
}
