singleton TSShapeConstructor(Zombie_Run_01DAE)
{
   baseShape = "./Zombie_Run_01.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Run_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run_01", "740", "760");
}
