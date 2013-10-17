singleton TSShapeConstructor(Mantis_Kraad_SideDAE)
{
   baseShape = "./Mantis_Kraad_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "510", "529", true, true);
}
