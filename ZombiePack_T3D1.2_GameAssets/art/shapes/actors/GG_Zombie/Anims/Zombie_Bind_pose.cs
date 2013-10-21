singleton TSShapeConstructor(Zombie_Bind_poseDAE)
{
   baseShape = "./Zombie_Bind_pose.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Bind_poseDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Bind_pose", "0", "10");
}
