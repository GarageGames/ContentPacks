singleton TSShapeConstructor(Soldier_Kralmok_Death2DAE)
{
   baseShape = "./Soldier_Kralmok_Death2.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Death2DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death2", "1160", "1200", true, true);
}
