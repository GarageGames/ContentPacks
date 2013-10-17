singleton TSShapeConstructor(PlayerAnim_Mamba_JumpDAE)
{
   baseShape = "./PlayerAnim_Mamba_Jump.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "1000", "1010");
}
