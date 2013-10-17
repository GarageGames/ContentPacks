singleton TSShapeConstructor(Soldier_Kraad_RootDAE)
{
   baseShape = "./Soldier_Kraad_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "50", "109", true, true);
}
