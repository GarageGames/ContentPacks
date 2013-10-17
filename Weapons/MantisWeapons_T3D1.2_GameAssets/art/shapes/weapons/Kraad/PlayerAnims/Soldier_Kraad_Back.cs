singleton TSShapeConstructor(Soldier_Kraad_BackDAE)
{
   baseShape = "./Soldier_Kraad_Back.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "250", "269", true, true);
}
