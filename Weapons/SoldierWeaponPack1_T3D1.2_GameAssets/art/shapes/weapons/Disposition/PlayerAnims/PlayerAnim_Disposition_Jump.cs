singleton TSShapeConstructor(PlayerAnim_Disposition_JumpDAE)
{
   baseShape = "./PlayerAnim_Disposition_Jump.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "890", "900");
}
