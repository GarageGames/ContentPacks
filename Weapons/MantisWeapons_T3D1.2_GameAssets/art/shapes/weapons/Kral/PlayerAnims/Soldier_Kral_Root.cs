singleton TSShapeConstructor(Soldier_Kral_RootDAE)
{
   baseShape = "./Soldier_Kral_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "50", "109", true, true);
}
