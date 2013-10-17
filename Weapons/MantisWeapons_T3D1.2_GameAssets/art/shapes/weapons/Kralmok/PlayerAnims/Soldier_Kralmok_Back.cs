singleton TSShapeConstructor(Soldier_Kralmok_BackDAE)
{
   baseShape = "./Soldier_Kralmok_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "240", "259", true, true);
}
