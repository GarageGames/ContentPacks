singleton TSShapeConstructor(Mantis_Kraad_ReloadDAE)
{
   baseShape = "./Mantis_Kraad_Reload.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Reload", "1120", "1210", true, true);
}
