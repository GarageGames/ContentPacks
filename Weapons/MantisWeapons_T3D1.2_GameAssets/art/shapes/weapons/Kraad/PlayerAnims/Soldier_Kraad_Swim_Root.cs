singleton TSShapeConstructor(Soldier_Kraad_Swim_RootDAE)
{
   baseShape = "./Soldier_Kraad_Swim_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Swim_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Root", "1400", "1459", true, true);
}
