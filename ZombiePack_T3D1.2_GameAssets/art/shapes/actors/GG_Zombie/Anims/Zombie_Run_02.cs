singleton TSShapeConstructor(Zombie_Run_02DAE)
{
   baseShape = "./Zombie_Run_02.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Run_02DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run_02", "790", "810");
}
