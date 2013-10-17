singleton TSShapeConstructor(PlayerAnim_Ender__Bind_PoseDAE)
{
   baseShape = "./PlayerAnim_Ender__Bind_Pose.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender__Bind_PoseDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "_Bind_Pose", "0", "1");
}
