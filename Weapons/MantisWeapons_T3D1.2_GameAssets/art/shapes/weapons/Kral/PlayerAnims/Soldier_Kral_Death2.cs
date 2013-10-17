singleton TSShapeConstructor(Soldier_Kral_Death2DAE)
{
   baseShape = "./Soldier_Kral_Death2.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Death2DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death2", "1200", "1240", true, true);
}
