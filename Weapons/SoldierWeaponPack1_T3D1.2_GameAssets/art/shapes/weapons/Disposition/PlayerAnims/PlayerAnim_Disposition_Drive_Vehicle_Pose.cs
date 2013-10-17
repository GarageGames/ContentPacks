singleton TSShapeConstructor(PlayerAnim_Disposition_Drive_Vehicle_PoseDAE)
{
   baseShape = "./PlayerAnim_Disposition_Drive_Vehicle_Pose.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Drive_Vehicle_PoseDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Drive_Vehicle_Pose", "1170", "1175");
}
