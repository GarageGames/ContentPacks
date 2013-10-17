singleton TSShapeConstructor(Mantis_Kral_ReloadDAE)
{
   baseShape = "./Mantis_Kral_Reload.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1120", "1210", true, true);
}
