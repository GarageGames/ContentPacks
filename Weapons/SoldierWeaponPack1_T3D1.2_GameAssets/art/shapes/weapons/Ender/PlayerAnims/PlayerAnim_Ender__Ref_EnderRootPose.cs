singleton TSShapeConstructor(PlayerAnim_Ender__Ref_EnderRootPoseDAE)
{
   baseShape = "./PlayerAnim_Ender__Ref_EnderRootPose.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender__Ref_EnderRootPoseDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "_Ref_EnderRootPose", "40", "41");
}
