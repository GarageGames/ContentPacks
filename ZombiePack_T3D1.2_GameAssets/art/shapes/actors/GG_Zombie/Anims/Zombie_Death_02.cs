singleton TSShapeConstructor(Zombie_Death_02DAE)
{
   baseShape = "./Zombie_Death_02.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Death_02DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Death_02", "1110", "1160");
}
