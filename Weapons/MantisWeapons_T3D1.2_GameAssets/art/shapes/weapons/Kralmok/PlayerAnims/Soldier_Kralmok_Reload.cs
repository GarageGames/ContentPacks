singleton TSShapeConstructor(Soldier_Kralmok_ReloadDAE)
{
   baseShape = "./Soldier_Kralmok_Reload.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1720", "1820", true, true);
}
