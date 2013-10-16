singleton TSShapeConstructor(PlayerAnim_Lurker_JumpDAE)
{
   baseShape = "./PlayerAnim_Lurker_Jump.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "1000", "1010");
}
