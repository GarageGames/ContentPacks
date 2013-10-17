singleton TSShapeConstructor(Soldier_Kraad_HeadDAE)
{
   baseShape = "./Soldier_Kraad_Head.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "900", "910", true, true);
}
