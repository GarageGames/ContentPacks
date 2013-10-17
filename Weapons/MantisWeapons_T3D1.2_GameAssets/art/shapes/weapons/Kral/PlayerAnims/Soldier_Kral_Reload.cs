singleton TSShapeConstructor(Soldier_Kral_ReloadDAE)
{
   baseShape = "./Soldier_Kral_Reload.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1310", "1385", true, true);
}
