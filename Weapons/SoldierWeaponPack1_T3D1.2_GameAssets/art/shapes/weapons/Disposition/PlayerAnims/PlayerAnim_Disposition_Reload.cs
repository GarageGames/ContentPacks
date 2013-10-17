singleton TSShapeConstructor(PlayerAnim_Disposition_ReloadDAE)
{
   baseShape = "./PlayerAnim_Disposition_Reload.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1780", "1870");
}
