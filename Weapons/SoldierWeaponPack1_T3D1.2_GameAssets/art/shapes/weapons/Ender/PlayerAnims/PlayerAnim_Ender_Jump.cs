singleton TSShapeConstructor(PlayerAnim_Ender_JumpDAE)
{
   baseShape = "./PlayerAnim_Ender_Jump.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "900", "910");
}
