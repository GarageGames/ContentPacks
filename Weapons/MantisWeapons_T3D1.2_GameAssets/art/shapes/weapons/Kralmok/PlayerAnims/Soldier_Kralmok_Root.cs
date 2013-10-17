singleton TSShapeConstructor(Soldier_Kralmok_RootDAE)
{
   baseShape = "./Soldier_Kralmok_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "50", "109", true, true);
}
