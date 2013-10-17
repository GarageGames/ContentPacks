singleton TSShapeConstructor(Soldier_Kralmok_SideDAE)
{
   baseShape = "./Soldier_Kralmok_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "190", "209", true, true);
}
