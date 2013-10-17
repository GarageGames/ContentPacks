singleton TSShapeConstructor(PlayerAnim_Ender_ReloadDAE)
{
   baseShape = "./PlayerAnim_Ender_Reload.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1720", "1820");
}
