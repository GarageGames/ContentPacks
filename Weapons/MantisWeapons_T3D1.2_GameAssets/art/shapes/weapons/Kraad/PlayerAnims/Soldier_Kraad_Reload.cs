singleton TSShapeConstructor(Soldier_Kraad_ReloadDAE)
{
   baseShape = "./Soldier_Kraad_Reload.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1880", "1970", true, true);
}
