singleton TSShapeConstructor(Mantis_Kraad_BindDAE)
{
   baseShape = "./Mantis_Kraad_Bind.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_BindDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Bind", "0", "1", true, true);
}
