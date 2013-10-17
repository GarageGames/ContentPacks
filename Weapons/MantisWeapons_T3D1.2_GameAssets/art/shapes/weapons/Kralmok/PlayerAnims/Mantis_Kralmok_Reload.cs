singleton TSShapeConstructor(Mantis_Kralmok_ReloadDAE)
{
   baseShape = "./Mantis_Kralmok_Reload.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Reload", "1120", "1210", true, true);
}
