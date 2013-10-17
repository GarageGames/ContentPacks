singleton TSShapeConstructor(Mantis_Kral_BindDAE)
{
   baseShape = "./Mantis_Kral_Bind.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_BindDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Bind", "0", "1", true, true);
}
