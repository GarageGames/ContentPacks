singleton TSShapeConstructor(Soldier_Kral_Swim_RootDAE)
{
   baseShape = "./Soldier_Kral_Swim_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Swim_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Root", "1420", "1479", true, true);
}
