singleton TSShapeConstructor(Soldier_Kraad_SideDAE)
{
   baseShape = "./Soldier_Kraad_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "200", "219", true, true);
}
