singleton TSShapeConstructor(Soldier_Kral_SideDAE)
{
   baseShape = "./Soldier_Kral_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "190", "209", true, true);
}
