singleton TSShapeConstructor(Soldier_Kralmok_Swim_BackDAE)
{
   baseShape = "./Soldier_Kralmok_Swim_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Swim_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Back", "1450", "1509", true, true);
}
