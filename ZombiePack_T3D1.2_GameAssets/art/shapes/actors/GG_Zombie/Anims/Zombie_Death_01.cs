singleton TSShapeConstructor(Zombie_Death_01DAE)
{
   baseShape = "./Zombie_Death_01.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Death_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Death_01", "1020", "1080");
}
