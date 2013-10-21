singleton TSShapeConstructor(Zombie_Idle_01DAE)
{
   baseShape = "./Zombie_Idle_01.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Idle_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Idle_01", "30", "150");
}
