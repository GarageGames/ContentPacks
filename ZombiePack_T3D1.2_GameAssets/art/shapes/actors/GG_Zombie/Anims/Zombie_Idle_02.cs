singleton TSShapeConstructor(Zombie_Idle_02DAE)
{
   baseShape = "./Zombie_Idle_02.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Idle_02DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Idle_02", "180", "300");
}
