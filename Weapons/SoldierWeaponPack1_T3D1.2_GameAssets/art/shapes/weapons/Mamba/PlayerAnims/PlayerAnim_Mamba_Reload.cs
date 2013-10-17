singleton TSShapeConstructor(PlayerAnim_Mamba_ReloadDAE)
{
   baseShape = "./PlayerAnim_Mamba_Reload.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1880", "1970");
}
