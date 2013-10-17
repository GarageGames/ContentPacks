singleton TSShapeConstructor(PlayerAnim_Mamba__Ref_RifleRootPoseDAE)
{
   baseShape = "./PlayerAnim_Mamba__Ref_RifleRootPose.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba__Ref_RifleRootPoseDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "_Ref_RifleRootPose", "40", "41");
}
